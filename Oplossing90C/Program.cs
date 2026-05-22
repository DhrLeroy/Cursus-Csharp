using Oplossing90C;

var b1 = new Bankrekening(200);

try
{
    b1.HaalAf(1000);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}