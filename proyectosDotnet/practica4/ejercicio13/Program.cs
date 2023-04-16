//13) Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing (??) y/o la asignación null-coalescing (??=)

string? st = "";
string? st1 = null;
string? st2 = null;
string? st3 = null;
string? st4 = null;

if (st1 == null)
{
    if (st2 == null)
    {
        st = st3;
    }
    else
    {
        st = st2;
    }
}
else
{
    st = st1;
}



if (st4 == null)
{
    st4 = "valor por defecto";
}


st = st1 ?? st3 ?? st2 ?? st1;
st4 ??= "valor por defecto";

if(st==null)
    Console.WriteLine("NULL");
else
    Console.WriteLine(st4);

Console.ReadLine();





