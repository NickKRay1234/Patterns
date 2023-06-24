namespace Generics.Scripts
{
    public class Soldier<T>
    {
        public T ID { get; }
        public string Name { get; }
        public uint Experience { get; }

        public Soldier(T id, string name, uint experience)
        {
            ID = id;
            Name = name;
            Experience = experience;
        }
    }
}