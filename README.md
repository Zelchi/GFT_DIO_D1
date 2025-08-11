# Sistema de Estacionamento

Um sistema simples de gerenciamento de estacionamento desenvolvido em C# (.NET 9.0).

## 📋 Funcionalidades

- **Cadastrar veículo**: Adiciona um veículo ao estacionamento através da placa
- **Remover veículo**: Remove um veículo e calcula o valor total a ser pago
- **Listar veículos**: Exibe todos os veículos atualmente estacionados
- **Configuração de preços**: Define preço inicial e preço por hora

## 🚀 Como executar

1. Clone o repositório
2. Navegue até a pasta do projeto
3. Execute o comando:
```bash
dotnet run
```

## 💰 Cálculo de preços

O valor total é calculado da seguinte forma:
```
Valor Total = Preço Inicial + (Preço por Hora × Horas estacionadas)
```

## 🛠️ Tecnologias utilizadas

- C# (.NET 9.0)
- Console Application

## 📁 Estrutura do projeto

- `Program.cs` - Ponto de entrada da aplicação
- `Menu.cs` - Interface do menu principal
- `Estacionamento.cs` - Lógica de gerenciamento do estacionamento
- `Input.cs` - Utilitários para entrada de dados com validação

---

*Projeto desenvolvido como parte do Desafio de Fundamentos em C#*