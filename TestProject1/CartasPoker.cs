// See https://aka.ms/new-console-template for more information

public class CartasPoker
{
    public string Valor {get; set;} = string.Empty;
    public string Naipe{get; set;} = string.Empty;
    public string Simbolo {get; set;} = string.Empty;

    public List<string> simboloCartas =[
        "2O", "2C", "2E", "2P",
        "3O", "3C", "3E", "3P", 
        "4O", "4C", "4E", "4P", 
        "5O", "5C", "5E", "5P",
        "6O", "6C", "6E", "6P", 
        "7O", "7C", "7E", "7P", 
        "8O", "8C", "8E", "8P", 
        "9O", "9C", "9E", "9P",
        "DO", "DC", "DE", "DP", 
        "JO", "JC", "JE", "JP", 
        "QO", "QC", "QE", "QP", 
        "KO", "KC", "KE", "KP", 
        "AO", "AC", "AE", "AP"
    ];

    public string ValidarCarta(string carta)
    {
        for (int i = 0; i < simboloCartas.Count; i++)
        {
            if (simboloCartas[i] == carta)
            {
                return "Carta válida";
            }
        }

        return "Carta Inválida";
    }

    public string ValidarValorCarta(string carta, string valor)
    {
        
    }
}
