# Desafio South


## Execução dos testes
Com o .NET Core pré instalado executar o comando "dotnet test".

## Abordagem

### Solução
Para cada letra que bater com a expressão regular "[a-z]", utilizando "ignorecase", é testado se o caracter é a última letra do alfabeto, caso seja, voltamos para o início, exemplo: "z" para "a" ou "Z" para "A", caso contrário é incrementado o caracter em 1. Após este processo o caracter é capitalizado caso seja uma vogal.

### Estrutura
Foi criada a biblioteca "DesafioSouth" e dentro a classe "Deformador" que por sua vez contém o método "Deformar" e um método estático auxilizar que executa o "Evaluator" que é utilizado pelo método "Regex.Replace".
Para o teste foi utilizada a ferramenta de teste xUnit, os testes constam no projeto "DesafioSouthXUnitTest".

