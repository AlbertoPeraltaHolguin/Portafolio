package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageButton
import android.widget.TextView
import java.util.Calendar

class EdadActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_edad)


        //Variables de calculo
        val Calcular: Button =findViewById(R.id.buttonCal)
        val editTextEdad: EditText =findViewById(R.id.editTextEdad)
        val textViewEdad: TextView = findViewById(R.id.textViewEdad)

        Calcular.setOnClickListener{
            val Nacimiento: Int=editTextEdad.text.toString().toInt()
            val Actual:Int= Calendar.getInstance().get(Calendar.YEAR)
            val Edad: Int= Actual-Nacimiento

            textViewEdad.text="Tienes: $Edad Años"
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