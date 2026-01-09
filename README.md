## 🎵 ScreenSound

Projeto desenvolvido em **C#** com foco em **Programação Orientada a Objetos (POO)**, simulando um sistema simples de músicas, inspirado em um serviço de streaming.

O objetivo do projeto é praticar conceitos como:
- Classes e objetos
- Propriedades
- Métodos
- Encapsulamento
- Uso de `bool`, `string` e `int`
- Saída de dados no console

---

## 🚀 Funcionalidades

- Cadastro de músicas
- Exibição da ficha técnica da música
- Verificação de disponibilidade da música no plano
- Exibição de mensagens diferentes para músicas disponíveis ou não

---

## 🧱 Estrutura da Classe `Mussica`

A classe `Mussica` possui as seguintes propriedades:

- **Nome**: Nome da música
- **Artista**: Nome do artista
- **Duracao**: Duração da música em segundos
- **Disponivel**: Indica se a música está disponível no plano
- **DescricaoResumida**: Retorna uma descrição resumida da música

E o método principal:

- **ExibirFichaTecnica()** → Exibe todas as informações da música no console

---

## 💻 Exemplo de Uso

```csharp
Mussica musica1 = new Mussica();
musica1.Nome = "Imagine";
musica1.Artista = "John Lennon";
musica1.Duracao = 183;
musica1.Disponivel = true;

Mussica musica2 = new Mussica();
musica2.Nome = "Billie Jean";
musica2.Artista = "Michael Jackson";
musica2.Duracao = 294;
musica2.Disponivel = false;

musica2.ExibirFichaTecnica();
ScreenSound-Alura
