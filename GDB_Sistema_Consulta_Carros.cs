using System;

class Program 
{
    
    static void Main() 
    {
        // Arrays das categorias
        
        string[] categorias = { "Hatch", "Sedan", "SUV" };
        
        // Arrays individuais para cada categoria com seus respectivos modelos
        
        string[] modelosHatch = {"Fiat Argo", "Volkswagem Gol", "Ford Ka" };
        string[] modelosSedan = { "Toyota Corolla", "Honda Civic", "Chevrolet Onix Plus" };
        string[] modelosSUV = { "Jeep Compass", "Hyundai Creta", "Honda HR-V" };
        
        // Arrays para informações adicionais: Tipos de motor dos modelos, consumo e preços organizados por categoria
        
        string[] motoresHatch = { "1.0 Flex", "1.6 Flex", "1.0 Flex" };
        string[] motoresSedan = { "2.0 Flex", "1.5 Turbo Flex", "1.0 Turbo" };
        string[] motoresSUV = { "2.0 Flex", "1.6 Flex", "1.5 Turbo Flex" };
        
        string[] consumosHatch = { "12 km/l", "11 km/l", "13 km/l" };
        string[] consumosSedan = { "10 km/l", "11.5 km/l", "14 km/l" };
        string[] consumosSUV = {"9 km/l", "10.5 km/l", "12.5 km/l" };
        
        decimal[] precosHatch = { 62000, 58000, 54000 };
        decimal[] precosSedan = { 148000, 142000, 97000 };
        decimal[] precosSUV = { 175000, 128000, 135000 };
        
        // Loop para o programa rodar até que o usuário decida sair
        
        bool continuar = true;
        
        while (continuar)
        {
            // loop for para exibir as categorias enumeradas
            
            Console.WriteLine("\nCategorias disponíveis:");
            for (int i = 0; i < categorias.Length; i++)
            {
                // Ajusta o índice para que o usuário veja as opções a partir de 1 em vez de 0
                
                Console.WriteLine($"{i+1}. {categorias[i]}");
            }
            
            //Opção para o usuário selecionar a categoria
            
            Console.WriteLine("\nSelecione uma categoria (1 a 3): ");
            int categoriaEscolhida = int.Parse(Console.ReadLine()) - 1; //-1 ajusta a entrada para que "1" corresponda ao índice 0.
            
            //Validação da categoria
            
            if (categoriaEscolhida < 0 || categoriaEscolhida >= categorias.Length)
            {
                Console.WriteLine("Categoria inválida!");
                continue;
            }
            
            // Escolher o array correto com base na categoria e informações adicionais usando operador ternário (?:)
            
            string[] modelos = categoriaEscolhida == 0 ? modelosHatch : categoriaEscolhida == 1 ? modelosSedan : modelosSUV;
            string[] motores = categoriaEscolhida == 0 ? motoresHatch : categoriaEscolhida == 1 ? motoresSedan : motoresSUV;
            string[] consumos = categoriaEscolhida == 0 ? consumosHatch : categoriaEscolhida == 1 ? consumosSedan : consumosSUV;
            decimal[] precos = categoriaEscolhida == 0 ? precosHatch : categoriaEscolhida == 1 ? precosSedan : precosSUV;
            
            // Exibir modelos disponíveis
            
            Console.WriteLine($"\nModelos disponíveis da categoria {categorias[categoriaEscolhida]}:");
            int indice = 1;
            foreach (string modelo in modelos)
            {
                Console.WriteLine($"{indice}. {modelo}");
                indice++;
            }
            
            // Escolher modelo - o código converte para o índice do array.
            
            Console.WriteLine("\nSelecione um modelo (1 a 3): ");
            int modeloEscolhido = int.Parse(Console.ReadLine()) - 1;
            
            // Validação - Se o número for inválido, exibe uma mensagem e reinicia o loop.
            if (modeloEscolhido < 0 || modeloEscolhido >= modelos.Length)
            {
                Console.WriteLine("Modelo inválido!");
                continue;
            }
            
            // Exibe as informações completas do modelo escolhido
            
            Console.WriteLine("\n--- Informações do modelo selecionado ---");
            Console.WriteLine($"Modelo: {modelos[modeloEscolhido]}");
            Console.WriteLine($"Preço: R$ {precos[modeloEscolhido]:N2}"); // N2 - Formata com 2 casas decimais
            Console.WriteLine($"Motor: {motores[modeloEscolhido]}");
            Console.WriteLine($"Consumo: {consumos[modeloEscolhido]}");
            
            // Pergunta se o usuário quer continuar
            
            Console.WriteLine("\nDeseja consultar outro modelo? (s/n): ");
            string resposta = Console.ReadLine();
            
            if (resposta!="s")
                continuar = false;
        }
        
        // Mensagem de encerramento
        Console.WriteLine("\nObrigado por utilizar o sistema de consulta!");
    }
}