# Desafio South


## Execução ds testes
Com o dot net core pré instalado executar o comando "dotnet test"

## Abordagem

Para cada letra que bater com a expressão regular "[a-z]", utilizando "ignorecase", é testado se o caracter é a última letra do alfabeto, caso seja, voltamos para o início, exemplo: "z" para "a" ou "Z" para "A", caso contrário é incrementado o caracter em 1. Após este proceso o caracter é captalizado caso seja uma vogal.

