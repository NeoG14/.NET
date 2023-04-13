using ejercicio4;

//new Hora(23, 30, 15).Imprimir();

decimal d = 0.45114m;



void decimales(decimal n){
    string hora = n.ToString("0");
    double hour = double.Parse(hora);
    string minutos = ((decimal.Parse(n.ToString()) - decimal.Parse(hora)) * 60).ToString().Substring(0,2);
    double min = double.Parse(minutos);
    string segundos =  ((decimal.Parse(n.ToString()) - decimal.Parse(n.ToString("0")) ) * 60 ).ToString().Substring(2);
    double seg = double.Parse(segundos)*60;
    Console.WriteLine($"{hour} Horas, {min} Minutos y {seg:0.000} Segundos ");
}


//Console.WriteLine(60*d);


new Hora(23, 30, 15).Imprimir();
new Hora(14.43).Imprimir();
new Hora(14.45).Imprimir();
new Hora(14.45114).Imprimir();


Console.ReadLine();

