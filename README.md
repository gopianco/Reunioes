# Reunioes

Bem vindo ao sistema de agendamentos de reuniões.

Esste sistema foi construido com:

  - ASP.NET Core 2.2.0 e C# para o Back-End
  - Angular 6 e TypeScript para o Front-End
  - Bootstrap para o layout
  - Entity Framework Core como ORM
  - MySql Database como Base de Dados
  
 Para Rodar o projeto siga as instruções:
 
 - Faça donwload do .net 2.2.0 <a href="https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.100-windows-x64-binaries">aqui<a>
 - Faça a instalação do MySql - seguindo as configurações que se encontrar em config.json ("Server=127.0.0.1;Uid=root;Pwd=123qweR@;database=test")
 - Faça donwload e instalação do Angular 6
 - Abra o Projeto com o Visual Studio
 - Abra o Console de Gerenciamento de Pacotes e rode os seguintes comandos:
    - Selecione o Projeto Padrão > Reunioes.Repositorio e rode o comando : Update-Database
 - Abra o terminal na pasta \reunioes\Reunioes\ClientApp\ e insira o comando: npm start
 - Rode o servidor IIS Express no Visual Studio
 
 Após a compilação, irá abrir a janela do navegador, cadastre algumas salas e reuniões.
    
