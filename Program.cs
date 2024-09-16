Random random = new Random();
int randomNumber= random.Next (0,101);
bool gissat_ratt = false; 
int antal_forsok = -1;

Console.WriteLine ("Gissa ett tal mellan 1 till 100");

while (!gissat_ratt)
{
    antal_forsok++;
    Console.Write("Din gissning: "); 
    int gissning;
    if (int.TryParse(Console.ReadLine(), out gissning) )
    {
        
        if(gissning < randomNumber)
        {
            Console.WriteLine("För lågt, gissa igen");
        }
        else if (gissning > randomNumber)
        {
            Console.WriteLine ("För högt, gissa igen");
        }
        else 
        { 
            gissat_ratt = true;
            antal_forsok++;
            Console.WriteLine ($"Grattis du gissade rätt på {antal_forsok} försök.");
        }

    }
}

