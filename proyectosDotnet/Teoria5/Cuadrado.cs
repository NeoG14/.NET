namespace Teoria5;
 class Cuadrado
 {
    private double _lado;

    //public void SetLado(double value) => _lado = value;
    //public double GetLado() => _lado;

    //Propiedad de lectura/escritura
    /*
    public double Lado
    {
        set {
            _lado = value;
        }
        get {
            return _lado;
        }
    }
    */
    //Equivalente a lo de arriba
    public double Lado
    {
        get =>  _lado;
        set => _lado = value;
    }
    

    //Propiedad de solo Escritura
    /*
    public double Area {
        get {
            return _lado * _lado;
        }
    }
    */

    //Equivalente a lo de arriba
    /*
    public double Area {
        get => _lado * _lado;
    }
    */

    //Equivalente a lo de arriba (Solo propiedades de lectura)
    public double Area => _lado * _lado;

    /*
    No es aconsejable el uso de propiedades de sólo
    escritura. Si la intención es desencadenar algún
    efecto secundario cuando se asigna el valor, es
    preferible usar un método en lugar de una
    propiedad.
    */



 }
