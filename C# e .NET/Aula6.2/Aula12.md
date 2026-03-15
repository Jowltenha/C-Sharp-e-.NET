# Aula 6.2("12") - Assuntos cobertos: Testes de unidade com C#

## 📌 Os Vários Tipos de Testes
Para garantir a qualidade de um software, aplicamos diferentes níveis de testes:

* **Testes de Unidade:** Validam a menor unidade lógica do código (geralmente um método) de forma isolada.
* **Testes de Integração:** Verificam se diferentes módulos ou serviços (como banco de dados e APIs) funcionam bem juntos.
* **Testes de Sistema (E2E):** Testam o fluxo completo da aplicação, do início ao fim, simulando o comportamento do usuário.
* **Testes de Regressão:** Garantem que novas alterações não quebraram funcionalidades que já estavam funcionando.

---

## Pacotes Populares para Teste de Unidade
No ecossistema C#, os três frameworks mais utilizados são:

1. **xUnit.net:** O padrão moderno mais popular, focado em extensibilidade e flexibilidade.
2. **NUnit:** Um clássico do .NET com uma sintaxe baseada em *Assertions* muito rica.
3. **MSTest:** O framework oficial da Microsoft, integrado nativamente ao Visual Studio.

> **Dica:** Para simular dependências (Mocks), o pacote **Moq** ou **NSubstitute** são essenciais. Para asserções mais fluidas, o **FluentAssertions** é uma ótima escolha.

---

## Padrão AAA (Arrange-Act-Assert)
O padrão AAA é a melhor forma de organizar a estrutura de um teste para que ele seja legível e padronizado:

- **Arrange (Organizar):** Prepara o cenário. Aqui você cria os objetos, inicializa variáveis e configura mocks.
- **Act (Agir):** Executa a ação ou o método específico que você deseja testar.
- **Assert (Verificar):** Valida se o resultado obtido foi o esperado.

---
    [Fact]
    public void Somar_DeveRetornarSomaCorreta()
    {
        // Arrange
        var calc = new Calculadora();
        int a = 5, b = 10;
    
        // Act
        var resultado = calc.Somar(a, b);
    
        // Assert
        Assert.Equal(15, resultado);
    }