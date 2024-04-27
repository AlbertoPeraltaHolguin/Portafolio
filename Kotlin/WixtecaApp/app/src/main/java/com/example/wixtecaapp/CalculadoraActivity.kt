package com.example.wixtecaapp

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.EditText

class CalculadoraActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_calculadora)
    }
        //Para crea rlas funciones
    fun eventosBtn(view: View){
        //Estructura condicional
        if(nuevaOperacion){
            //Declaramos la variable, con la cual accedemos al editText
            val texNumbre:EditText=findViewById(R.id.editTextNumber)
            //Acedemos a la varable para inicializar los atributos.
            texNumbre.setText("")

        }
            nuevaOperacion=false
            //declaramos las variables
            val btnClicqueado=view as Button
            val editTextNumbre: EditText=findViewById(R.id.editTextNumber)
            //Declaramos la varible para colocar el valor de boton
            var ValorDelBtn:String=editTextNumbre.text.toString()

            //Declaramos cada uno de los botones
            val BCero:Button=findViewById(R.id.btn0)
            val BUno:Button=findViewById(R.id.btn1)
            val BDos:Button=findViewById(R.id.btn2)
            val BTres:Button=findViewById(R.id.btn3)
            val BCuatro:Button=findViewById(R.id.btn4)
            val BCinco:Button=findViewById(R.id.btn5)
            val BSeis:Button=findViewById(R.id.btn6)
            val BSiete:Button=findViewById(R.id.btn7)
            val BOcho:Button=findViewById(R.id.btn8)
            val BNueve:Button=findViewById(R.id.btn9)

            val BPunto:Button=findViewById(R.id.btnPunto)
            val BMsMs:Button=findViewById(R.id.btNMAsMenas)


            when(btnClicqueado.id){
                BCero.id->{ValorDelBtn+="0"}
                BUno.id->{ValorDelBtn+="1"}
                BDos.id->{ValorDelBtn+="2"}
                BTres.id->{ValorDelBtn+="3"}
                BCuatro.id->{ValorDelBtn+="4"}
                BCinco.id->{ValorDelBtn+="5"}
                BSeis.id->{ValorDelBtn+="6"}
                BSiete.id->{ValorDelBtn+="7"}
                BOcho.id->{ValorDelBtn+="8"}
                BNueve.id->{ValorDelBtn+="9"}
                BPunto.id->{ValorDelBtn+="."}
                BMsMs.id->{ValorDelBtn="-"+ValorDelBtn}
            }
            //Pasamos el valor del btn al editText
            editTextNumbre.setText((ValorDelBtn))

        }

    //Creacion de variables
    var operacion ="*"
    var numeroPrevio=""
    var nuevaOperacion=true

    //Funcion de las operacion "+,-,*,/
    fun operaciones(view: View){
        val btnCliqueado= view as Button
        //Decklaramos las variables de cuales
        val btnsuma: Button=findViewById(R.id.btnSuma)
        val btnresta: Button=findViewById(R.id.btnResta)
        val btnmulti: Button=findViewById(R.id.btnMulti)
        val btndiv: Button=findViewById(R.id.btnDiv)

        when(btnCliqueado.id){
            btnsuma.id->{operacion="+"}
            btnresta.id->{operacion="-"}
            btnmulti.id->{operacion="X"}
            btndiv.id->{operacion="/"}
        }
        //Vamos a declarar las variables para accerder apor medio del identificador
        val editTextNumber: EditText= findViewById(R.id.editTextNumber)
        //Asignamos el valor contenido a la variable
        numeroPrevio=editTextNumber.text.toString()
        nuevaOperacion=true


    }

    //Crear la funcion para los resultados
    fun resultado(view: View){
        val editTextNumber: EditText=findViewById(R.id.editTextNumber)

        //Aisgnamos la varable el contenido del editTex
        val numeroNuevo=editTextNumber.text.toString()

        //Declaramos la varable la cual le asignamos un valor null
        var numeroFinal: Double?=null

        //Cramos una estructura when
            when(operacion){
                "+"->numeroFinal=numeroPrevio.toDouble()+numeroNuevo.toDouble()
                "-"->numeroFinal=numeroPrevio.toDouble()-numeroNuevo.toDouble()
                "X"->numeroFinal=numeroPrevio.toDouble()*numeroNuevo.toDouble()
                "/"->numeroFinal=numeroPrevio.toDouble()/numeroNuevo.toDouble()
            }

        //Asignamos el resultado de la operacion
        editTextNumber.setText(numeroFinal.toString())
        nuevaOperacion=true

    }

    fun porcentaje(view: View){
        val editTextNumber: EditText= findViewById(R.id.editTextNumber)
        //Declaramos la variable a la cual asignamos el  resultado de la operacion
        val numero:Double=editTextNumber.text.toString().toDouble()/100

        //Establecemos el valor contenido en la variable hacia el textnumber
        editTextNumber.setText(numero.toString())
        nuevaOperacion=true
    }

    fun limpiar(view: View){
        val editTextNumber:EditText=findViewById(R.id.editTextNumber)
        editTextNumber.setText("0")
        nuevaOperacion=true
    }




}