using System;

Console.WriteLine("SISTEMA DE CONTROL DE MOTORES");
Console.WriteLine();

// Crear un objeto de la clase derivada MotorCD
MotorCD motorCD1 = new MotorCD();
MotorAc motorAC1 = new MotorAc();
Servomotor servomotor1 = new Servomotor();

// Capturar la información del objeto por medio del usuario
Console.Write("Ingrese el identificador del motor DC: ");
motorCD1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura del motor: ");
motorCD1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente del motor: ");
motorCD1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor en rpm: ");
motorCD1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Capturar la propiedad propia de MotorCD
Console.Write("Ingrese el voltaje del motor: ");
motorCD1.Voltaje = Convert.ToDouble(Console.ReadLine());

//Para motor AC
Console.Write("\nIngrese el identificador del motor AC: ");
motorAC1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura del motor: ");
motorAC1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente del motor: ");
motorAC1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del motor en rpm: ");
motorAC1.Velocidad = Convert.ToDouble(Console.ReadLine());

// Capturar la propiedad propia de MotorAC
Console.Write("Ingrese el número de fases del motor: ");
motorAC1.Fases = Convert.ToDouble(Console.ReadLine());

//Para servomotor
Console.Write("\nIngrese el identificador del servomotor: ");
servomotor1.Identificador = Console.ReadLine() ?? "Sin identificador";

Console.Write("Ingrese la temperatura del servomotor: ");
servomotor1.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la corriente del servomotor: ");
servomotor1.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la velocidad del servomotor en rpm: ");
servomotor1.Velocidad = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la posición del servomotor: ");
servomotor1.Posicion = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR DC");
Console.WriteLine($"Motor: {motorCD1.Identificador}");
Console.WriteLine($"Temperatura: {motorCD1.Temperatura} °C");
Console.WriteLine($"Corriente: {motorCD1.Corriente} A");
Console.WriteLine($"Velocidad: {motorCD1.Velocidad} rpm");
Console.WriteLine($"Voltaje: {motorCD1.Voltaje} V");

Console.WriteLine($"Estado: {motorCD1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {motorCD1.RevisarTemperatura()}");

//ac
Console.WriteLine();
Console.WriteLine("DATOS DEL MOTOR AC");
Console.WriteLine($"Motor: {motorAC1.Identificador}");
Console.WriteLine($"Temperatura: {motorAC1.Temperatura} °C");
Console.WriteLine($"Corriente: {motorAC1.Corriente} A");
Console.WriteLine($"Velocidad: {motorAC1.Velocidad} rpm");
Console.WriteLine($"Fases: {motorAC1.Fases}");

Console.WriteLine($"Estado: {motorAC1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {motorAC1.RevisarTemperatura()}");

//SERVIO
Console.WriteLine();
Console.WriteLine("DATOS DEL SERVOMOTOR");
Console.WriteLine($"Motor: {servomotor1.Identificador}");
Console.WriteLine($"Temperatura: {servomotor1.Temperatura} °C");
Console.WriteLine($"Corriente: {servomotor1.Corriente} A");
Console.WriteLine($"Velocidad: {servomotor1.Velocidad} rpm");
Console.WriteLine($"Posición: {servomotor1.Posicion} °");

Console.WriteLine($"Estado: {servomotor1.ObtenerEstado()}");
Console.WriteLine($"Revisión de temperatura: {servomotor1.RevisarTemperatura()}");

// CLASE BASE
class Motor
{
    // Propiedades comunes
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }

    // Método para determinar el estado
    public string ObtenerEstado()
    {
        if (Velocidad > 0)
            return "Motor en marcha";
        else
            return "Motor detenido";
    }

    // Método para revisar la temperatura
    public string RevisarTemperatura()
    {
        if (Temperatura > 70)
            return "ALERTA: Temperatura elevada";

        return "Temperatura normal";
    }
}


// CLASE DERIVADA
class MotorCD : Motor
{
    // Propiedad propia de la clase derivada
    public double Voltaje { get; set; }
}

class MotorAc : Motor
{
    public double Fases { get; set; }
}

class Servomotor : Motor
{
    public double Posicion { get; set; }
}