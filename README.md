# Projeto de Jogos - TrybeGames

Este projeto faz parte do desenvolvimento de um sistema para gerenciar e armazenar dados de jogos jogados por Trybers. O sistema permite realizar consultas e interagir com um banco de dados em memória, utilizando uma estrutura organizada em diretórios específicos.

## Estrutura do Projeto

- **Contracts/**: Contém as interfaces que as classes podem implementar.
- **Controller/**: Contém o controller responsável por interagir com a pessoa usuária e o banco de dados.
- **Database/**: Contém a classe que simula o banco de dados, com listas e métodos para consultas.
- **Models/**: Contém os modelos principais do sistema: `Game`, `Player` e `GameStudio`.
- **DTOs**: Utilizados para transferir dados entre camadas da aplicação. 

## Execução

O arquivo `Program.cs` cria uma base de dados em memória e apresenta um menu no console para interação com o sistema. 

## Pré-requisitos

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)

## Instalação

### 1. Clone o repositório

```bash
git clone https://github.com/arturpeixoto/projeto-de-jogos-csharp.git
```

### 2. Acesse o diretório do projeto

```bash
cd projeto-de-jogos-csharp
```

### 3. Restaure as dependências

```bash
dotnet restore src/
```

### 4. Execute o programa

```bash
dotnet run --project src/TrybeGames
```

## Como usar

O projeto pode ser executado via terminal, onde um menu será apresentado para realizar as interações necessárias com os jogos, jogadores e estúdios.

## Tecnologias Utilizadas

- C#
- .NET 6

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.
