namespace Teoria5;
class Familia
{
    public Persona? Padre { get; set; }
    public Persona? Madre { get; set; }
    public Persona? Hijo { get; set; }

    public Persona? this[int i]
    {
        get
        {
            if (i == 0) return Padre;
            else if (i == 1) return Madre;
            else if (i == 2) return Hijo;
            else return null;
        }
        set
        {
            if (i == 0) Padre = value;
            else if (i == 1) Madre = value;
            else if (i == 2) Hijo = value;
        }
    }

}
