namespace Generics.Scripts
{
    public class Army<T>
    {
        public T Military { get; set; }

        public Army(T military)
        {
            Military = military;
        }

        public void Swap<P>(ref P x, ref P y)
        {
            P temp = x;
            x = y;
            y = temp;
        }
    }
}