package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import android.content.pm.PackageManager
import android.net.Uri
import android.os.Build
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.provider.Settings
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.ImageButton
import android.widget.Toast
import androidx.core.app.ActivityCompat

class LlamadaActivity : AppCompatActivity() {
    private val PHONE_CODE=4000

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_llamada)



        val botonContacto:Button=findViewById(R.id.buttonContactos)
        botonContacto!!.setOnClickListener {
            val intenCall=Intent(Intent.ACTION_DIAL, Uri.parse("tel:6621901104"))
            startActivity(intenCall)
        }

        val Volver:ImageButton  =findViewById(R.id.imageButtonVolver)
        Volver.setOnClickListener {
            startActivity(this,MenuActivity::class.java)
        }



        //Varables declaradas
        val imagenPhone: ImageButton =findViewById(R.id.imageButtonPhone)
        val editPhone: EditText =findViewById(R.id.editTextCelular)

        //Evento de imagenPhone
        imagenPhone!!.setOnClickListener(object : View.OnClickListener{
            override fun onClick(v: View) {
                //Variable del numero telefonico
                val NumeroCel=editPhone!!.text.toString()

                //Comprobacion de campo vacio
                if(!NumeroCel.isEmpty()){ //Aca dice "SI numero cel es DISTINTO a vacio es que se cumple
                    if(Build.VERSION.SDK_INT>= Build.VERSION_CODES.M){
                        if(permisosUsuario(android.Manifest.permission.CALL_PHONE)){
                            val intelAceptado= Intent(Intent.ACTION_CALL, Uri.parse("tel: "+NumeroCel))
                            if(ActivityCompat.checkSelfPermission(this@LlamadaActivity,android.Manifest.permission.CALL_PHONE) != PackageManager.PERMISSION_GRANTED){
                                return
                            }
                            startActivity(intelAceptado)
                        }else{
                            if(!shouldShowRequestPermissionRationale(android.Manifest.permission.CALL_PHONE)){
                                requestPermissions(arrayOf(android.Manifest.permission.CALL_PHONE), PHONE_CODE)
                            }else{
                                //Enviamos un mensaje por medio de un toas
                                Toast.makeText(this@LlamadaActivity,"¿Quieres habilitar permisos?" ,
                                    Toast.LENGTH_LONG).show()
                                val IntentSell= Intent(Settings.ACTION_APPLICATION_DETAILS_SETTINGS)
                                IntentSell.addCategory(Intent.CATEGORY_DEFAULT) //Cargar una categoria
                                IntentSell.data= Uri.parse("Package"+packageName)

                                IntentSell.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                                IntentSell.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY)
                                IntentSell.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS)

                                startActivity(IntentSell)
                            }
                        }
                    }else{
                        VersionAntigua(NumeroCel)
                    }
                } else{
                    Toast.makeText(this@LlamadaActivity,"Ingrese un numero telefonico", Toast.LENGTH_LONG).show()
                }
            }

        })

    }

    //Logica de llamada
    override fun onRequestPermissionsResult(
        requestCode: Int,
        permissions: Array<out String>,
        grantResults: IntArray
    ) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults)



        //Añade un when que revise el requiesCode
        when(requestCode){
            PHONE_CODE->{
                //LAs variables asingnan parametros
                val permisos=permissions[0]
                val resultado= grantResults[0]

                //Hacemos una validacion de permisos
                if(permisos==android.Manifest.permission.CALL_PHONE){
                    //If en caso de negar los permisos
                    if(resultado==PackageManager.PERMISSION_GRANTED){
                        //En caso de no dar permisos se hace lo sisguiente
                        //Primero se declara la variable del numero telefonico
                        val phoneNumber:EditText=findViewById(R.id.editTextCelular)
                        phoneNumber!!.text.toString()
                        //Variable para quien aloja el intent
                        val intenCall=Intent(Intent.ACTION_CALL, Uri.parse("tel: "+phoneNumber))

                        //Validamos una vez mas los permisos
                        if(ActivityCompat.checkSelfPermission(this,android.Manifest.permission.CALL_PHONE)!=PackageManager.PERMISSION_GRANTED){
                            //En caso de el usuario rechaza el permiso
                            return
                        }
                        startActivity(intenCall)


                    }else{
                        //Se manda un mensaje de rechazo
                        Toast.makeText(this,"Has rechazado los permisos", Toast.LENGTH_LONG).show()
                    }
                }
            }


        }




    }


    fun permisosUsuario(permission: String):Boolean{
        //Variable que arroje resultados
        val result=this.checkCallingOrSelfPermission(permission)
        //Retornar el valor
        return result==PackageManager.PERMISSION_GRANTED
    }

    fun VersionAntigua(NumeroCelular:String){
        val intentCall= Intent(Intent.ACTION_CALL,Uri.parse("tel: "+NumeroCelular))
        if(permisosUsuario(android.Manifest.permission.CALL_PHONE)){
            if(ActivityCompat.checkSelfPermission(this,android.Manifest.permission.CALL_PHONE)!=PackageManager.PERMISSION_GRANTED){
                return
            }
            startActivity(intentCall)
        }
    }


    fun startActivity(activity: Activity, nextActivity: Class<*> ){
        val intent= Intent(activity,nextActivity)
        activity.startActivity(intent)
        activity.finish()

    }
}