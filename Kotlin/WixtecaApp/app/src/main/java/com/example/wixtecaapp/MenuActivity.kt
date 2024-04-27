package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.ImageButton

class MenuActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)

        val Web: ImageButton =findViewById(R.id.imageButtonWeb)
        Web.setOnClickListener {
            startActivity(this,WebActivity::class.java)
        }

        val Email: ImageButton =findViewById(R.id.imageButtonMail)
        Email.setOnClickListener {
            startActivity(this,EmailActivity::class.java)
        }

        val Edad: ImageButton =findViewById(R.id.imageButtonEdad)
        Edad.setOnClickListener {
            startActivity(this,EdadActivity::class.java)
        }

        val Calculadora: ImageButton =findViewById(R.id.imageButtonCalculadora)
        Calculadora.setOnClickListener {
            startActivity(this,CalculadoraActivity::class.java)
        }

        val Llamada: ImageButton =findViewById(R.id.imageButtonLlamada)
        Llamada.setOnClickListener {
            startActivity(this,LlamadaActivity::class.java)
        }

        val Camera: ImageButton =findViewById(R.id.imageButtonCamera)
        Camera.setOnClickListener {
            startActivity(this,WebActivity::class.java)
        }



        val botonCamera:ImageButton=findViewById(R.id.imageButtonCamera)
        botonCamera!!.setOnClickListener {
            val intentCamera=Intent("android.media.action.IMAGE_CAPTURE")
            startActivity(intentCamera)
        }
    }



    fun startActivity(activity: Activity, nextActivity: Class<*> ){
        val intent= Intent(activity,nextActivity)
        activity.startActivity(intent)
        activity.finish()

    }
}