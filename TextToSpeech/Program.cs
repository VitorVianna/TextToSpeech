using Google.Cloud.TextToSpeech.V1;
using TextToSpeech;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inicio Sistema!");

Console.WriteLine("Lê a planilha");
GoogleCloudAPI googleService = new GoogleCloudAPI();
string texto = "Um dos melhores movimentos para os membros superiores é o supino alternado com halteres. Abaixe lentamente um braço enquanto o braço oposto permanece estendido. Você vai trabalhar os músculos peitoral e o tríceps e sentir o core se estabilizar com esse exercício.";
string linguagem = "pt-BR";
string nomeArquivo = "DB_Alternating_Chest_Press";
string genero = "F";
string nomeVoz = "pt-BR-Neural2-C";


Console.WriteLine("Envia Texto e salva.");
googleService.TextToSpecch(texto, linguagem, nomeArquivo, genero, nomeVoz);
