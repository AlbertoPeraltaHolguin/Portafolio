package com.example.wixtecaapp

import android.app.Activity
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextClock
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val next:Button=findViewById(R.id.buttonSiguiente)
        next.setOnClickListener {
            startActivity(this,MenuActivity::class.java)
        }


        val txtReloj= findViewById(R.id.textClock) as TextClock
        txtReloj.setOnClickListener{
            Toast.makeText(this@MainActivity,"TextClock", Toast.LENGTH_LONG).show()
        }
    }

    fun startActivity(activity: Activity, nextActivity: Class<*> ){
        val intent= Intent(activity,nextActivity)
        activity.startActivity(intent)
        activity.finish()

    }

}