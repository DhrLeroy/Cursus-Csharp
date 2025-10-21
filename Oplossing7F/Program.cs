using Oplossing7F;

var bibMerelbekeCentrum = new Bibliotheek("Dorpsplein 1 - 9820 Merelbeke", "Sofie", true);
var bibMelleCentrum = new Bibliotheek("Stationsstraat 10 - 9090 Melle", "Jan", false);
var bibMelleLijstnet = new Bibliotheek("Lijsternest 5 - 9090 Melle", "Els", true);

bibMelleCentrum.VoegBoekToe("De ontdekking van de hemel", "Harry Mulisch", 912, "Fictie");
bibMelleCentrum.VoegBoekToe("Het gouden ei", "Tim Krabbé", 160, "Thriller");
bibMerelbekeCentrum.VoegBoekToe("De aanslag", "Harry Mulisch", 256, "Fictie");

var geleendBoek = bibMerelbekeCentrum.Ontleen("De aanslag", "Harry Mulisch");

bibMelleCentrum.VerwijderBoek("Het gouden ei", "Tim Krabbé");