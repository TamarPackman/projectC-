public class Towitems
{
    char c1; char c2;
    public Towitems(char c1, char c2)
    {
        this.c1 = c1;
        this.c2 = c2;
    }
    public string toString()
    {
        return "(" + c1 + "," + c2 + ")";
    }
}
public class Program
{


    public static char last(Stack<char> st, char c)
    {
        if (st!=null)
        {
            char c2 = st.Pop();
            c = (last(st, c2));
            if (c != c2)
                st.Push(c2);
        }
        return c;
    }
    public static Stack<Towitems> what(Stack<char> st)
    {
        Stack<Towitems> st2 = new Stack<Towitems>();
        while (st!=null)
        {
            char c = last(st, ' ');
            st2.Push(new Towitems(st.Pop(), c));
        }
        return st2;
    }
    public static void Main(string[] args)
    {
        Stack<char> st1 = new Stack<char>();
        st1.Push('b'); st1.Push('c'); st1.Push('d'); st1.Push('f'); st1.Push('h'); st1.Push('k');
        Stack<Towitems> st2 = what(st1);
        Console.WriteLine(st2);
    }
}


