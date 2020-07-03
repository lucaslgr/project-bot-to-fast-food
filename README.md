<a href="./LICENSE">![GitHub](https://img.shields.io/badge/license-MIT-green)</a>

# PROJETO BOT PARA FAST-FOOD

## :rocket: Tecnologias utilizadas

<li>C#</li>
<li>Microsoft BotBuilder</li>
<li>LUIS</li>
<li>QnA Maker</li>

## :loudspeaker: Apresentação

Este projeto é um BOT que opera pelos canais Telegram e Skype desenvolvido com C# e .NET e utilizando API LUIS de serviços cognitivos providas por IA para interpretação inteligente das mensagens enviadas pelo cliente.

<b>- Link para vídeo de demonstração:</b> 

[[Publicação no Youtube]](https://www.youtube.com/watch?v=hxmH17UhvIE)

## ⚙ Features

- [x] Conta com IA provida por uma RN evoluida com aprendizado supervisionado através da API LUIS para interpreção inteligente das mensagens.

- [x] Pode funcionar em vários canais, telegram, facebook, skype, slack, entre outros...

## :clipboard: Instruções para rodar o projeto

### Pré-requisitos

- Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:

<li>[Git](https://git-scm.com)</li>
<li>[.NET]</li>
<li>[Microsoft Bot Framework](https://dev.botframework.com/)</li>
<li>[Visual Studio Community](https://visualstudio.microsoft.com/pt-br/vs/community/)</li>

### Instalando e rodando o back-end:

```bash
# Clone este repositório
$ git clone https://github.com/lucaslgr/be-the-hero

# Acesse a pasta do projeto no terminal/cmd
$ cd be-the-hero

# Vá para a pasta Backend
$ cd backend

# Instale as dependências
$ npm install ou yarn add

# Execute a aplicação em modo de desenvolvimento
$ npm run dev ou yarn dev

# O servidor inciará na porta:3333 - acesse http://localhost:3333 
```

### Clonar este repositório:

```bash
# Clone este repositório
$ git clone https://github.com/lucaslgr/project-bot-to-fast-food
```

### Recuperar as chaves do QnA Maker:

Para utilizar o QnA Maker você precisará informar suas knowledgeBaseId e subscriptionKey dentro do arquivo Web.config, para isto basta acessar sua lista de serviços na plataforma QnA Maker e clicar no botão View Code do serviço a ser utilizado, a janela exibda conterá os dados que você precisa utilizar. A imagem abaixo demonstra a posição de cada item na tela.

### Recuperar a url do LUIS:

Para utilizar o LUIS você precisará informar seu Endpoint dentro do arquivo Web.config, para isto basta acessar sua aplicação na plataforma LUIS e acessar a aba Publish do serviço a ser utilizado, no final da página exibida estarão os dadores referentes à Resources and Keys, basta copiar a url listada. A imagem abaixo demonstra a posição do item na tela.

## 👨‍💻 Autoria

Lucas Guimarães

https://lucaslgr.github.io/

https://www.linkedin.com/in/lucas-guimar%C3%A3es-rocha-a30282132/

## Referências

A semana foi ministrada pelo [Maratona Bots Microsoft](https://ticapacitacion.com/curso/botspt/)
