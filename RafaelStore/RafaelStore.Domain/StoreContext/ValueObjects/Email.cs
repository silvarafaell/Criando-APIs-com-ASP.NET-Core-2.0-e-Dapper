namespace RafaelStore.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        //Construtor
        public Email(string adress)
        {
            Adress = adress;

        }
        public string Adress { get; private set; }

        public override string ToString()
        {
            return Adress;
        }
    }
}