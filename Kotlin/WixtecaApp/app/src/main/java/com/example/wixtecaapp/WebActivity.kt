package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import android.net.Uri
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageButton

class WebActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_web)

        val imagenWeb: ImageButton = findViewById(R.id.imageButton3)
        imagenWeb.setOnClickListener {
            val editWeb: EditText = findViewById(R.id.editWeb)
            val url= editWeb.text.toString()

        val intentWeb= Intent()
        intentWeb.data= Uri.parse("http://"+url+".com")
        intentWeb.action= Intent.ACTION_VIEW
        startActivity(intentWeb)
    }

        val Volver:ImageButton  =findViewById(R.id.imageButtonVolver)
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