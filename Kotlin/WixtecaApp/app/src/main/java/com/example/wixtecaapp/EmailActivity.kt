package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import android.net.Uri
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.ImageButton

class EmailActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_email)

        val Email: ImageButton = findViewById(R.id. imageButtonEmail)
        //accedemos a la funcion
        Email!!.setOnClickListener {
            //Decalarmos la variable la cual alokjaremos el correo
            val email="albertoperalta180@gmail.com"
            //Decalaramos la variable para asignar el intent
            val intenEmail=Intent(Intent.ACTION_SEND,  Uri.parse(email))
            intenEmail.type="plain/text"

            intenEmail.putExtra(Intent.EXTRA_SUBJECT, "Titulo de correo electronico")
            intenEmail.putExtra(Intent.EXTRA_TEXT, "En espera de una respuesta")
            intenEmail.putExtra(Intent.EXTRA_EMAIL, arrayOf("alguien@gmial.com","alguien1@gmail.com"))

            //Iniciamos el ectivity
            startActivity(Intent.createChooser(intenEmail, "Elige al cliente del correo"))



        }

        val Volver: ImageButton =findViewById(R.id.imageButtonVolver)
        Volver.setOnClickListener {
            startActivity(this,MenuActivity::class.java)
        }

    }


    fun startActivity(activity: Activity, nextActivity: Class<*> ){
        val intent= Intent(activity,nextActivity)
        activity.startActivity(intent)
        activity.finish()

    }
}