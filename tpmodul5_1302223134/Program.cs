HaloGeneric.SapaUser<String>("dias");
DataGeneric<String> data = new DataGeneric<string>("1302223134");
data.PrintData();

class HaloGeneric
{
	public static void SapaUser<T>(T user)
	{
        Console.WriteLine("Halo user " + user);
    }
}

class DataGeneric<T>
{
    readonly T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}