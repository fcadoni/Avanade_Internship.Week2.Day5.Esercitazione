namespace Avanade_Internship.Week2.Day5.Esercitazione.Entities
{
    public enum Category
    {
        Viaggio = 1,
        Alloggio,
        Vitto,
        Altro
    }
    public class Expence
    {
        public DateTime Date { get; set; }
        public Category Rating { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }


        public virtual string ToRow()
        {
        
            return $"{Date.ToShortDateString};{Rating};{Description};{Amount}";
        }

        public override string ToString()
        {
            return $"Data: {Date.ToShortDateString}\n" +
                    $"Categoria: {Rating}\n" +
                    $"Descrizione: {Description}\n" +
                    $"Costo: €{Amount}\n";
        }
    }

}