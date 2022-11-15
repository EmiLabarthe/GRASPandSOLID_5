namespace Full_GRASP_And_SOLID
{
    // Se agrega la interfaz de imprimible, para que por DIP, ConsolePrinter y FilePrinter dependan de ella y no de recipe.
    public interface IPrintable
    {
        string GetTextToPrint();
    }
}