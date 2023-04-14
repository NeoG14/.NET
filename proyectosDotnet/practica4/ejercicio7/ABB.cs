namespace ejercicio7;

class ABB
{
    public Nodo raiz;
    public Nodo aux;

    public int i = 0;

    public ABB()
    {
        raiz = null;
    }

    public bool tieneHi()
    {
        return raiz.hi != null;
    }

    public bool tieneHd()
    {
        return raiz.hd != null;
    }

    public Nodo insertar(int dato, Nodo nodo)
    {
        Nodo aux = null;

        if(nodo  == null)
        {
            aux = new Nodo();
            aux.dato = dato;
            return aux;
        }
        if(dato < nodo.dato)
            nodo.hi = insertar(dato,nodo.hi);
        else
            if(dato > nodo.dato)
                nodo.hd = insertar(dato,nodo.hd);
                
        return nodo;
    }

    public System.Collections.ArrayList getInOrden() 
    {
        System.Collections.ArrayList nums = new System.Collections.ArrayList();
        getInOrdenAux(this.raiz,nums);
        return nums;
    }

    private void getInOrdenAux(Nodo ab,System.Collections.ArrayList a) 
    {
        if(tieneHi())
           getInOrdenAux(raiz.hi,a);
            a.Add(raiz.dato);
        if(tieneHd())
           getInOrdenAux(raiz.hd,a);
    }
}