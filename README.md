# Jogo de Xadrez em C# (Console) ♟️

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

Este projeto consiste na implementação de um **jogo de xadrez completo para linha de comando** desenvolvido em C#. O principal objetivo foi aplicar e solidificar os **fundamentos da Programação Orientada a Objetos (POO)**, modelando as peças, o tabuleiro e as regras do jogo de forma robusta e extensível.

---

## ✨ Recursos e Funcionalidades

* **Tabuleiro Dinâmico:** Representação do tabuleiro de xadrez 8x8.
* **Movimentação de Peças:** Implementação das regras de movimento para todas as peças (Peão, Torre, Cavalo, Bispo, Rainha, Rei).
* **Captura de Peças:** Lógica para remoção de peças do tabuleiro.
* **Validação de Movimentos:** Verificação de movimentos válidos de acordo com as regras do xadrez, incluindo:
    * Verificação de caminho livre (para Torre, Bispo e Rainha).
    * Movimento inicial especial do Peão (2 casas) e captura diagonal.
    * Movimentos em "L" do Cavalo.
* **Controle de Turnos:** Alternância entre jogadores (Brancas e Pretas).
* **Tratamento de Exceções:** Lógica para lidar com jogadas inválidas (ex: mover para fora do tabuleiro, peça inimiga).
* **POO Pura:** Estruturação do código utilizando conceitos como:
    * **Herança:** Classes base para `Peca` e especializações para cada tipo de peça.
    * **Polimorfismo:** Métodos de movimentação sobrescritos para cada tipo de peça.
    * **Encapsulamento:** Propriedades e métodos privados/públicos para proteger o estado interno.
    * **Abstração:** Classes abstratas e interfaces para definir contratos.

---

## 🚀 Tecnologias Utilizadas

* **C#**: Linguagem de programação principal.
* **.NET**: Framework de desenvolvimento.

---

## 🛠️ Como Rodar o Projeto

Siga os passos abaixo para compilar e executar o jogo em sua máquina:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/LucMazarJR/xadrez-console.git
    ```
2.  **Navegue até o diretório do projeto:**
    ```bash
    cd xadrez-console
    ```
3.  **Compile o projeto:**
    ```bash
    dotnet build
    ```
4.  **Execute o jogo:**
    ```bash
    dotnet run
    ```
    * Alternativamente, você pode abrir o projeto no Visual Studio e executá-lo diretamente.

---

## 🎨 Exemplo de Uso (Linha de Comando)

Após executar o projeto, você verá o tabuleiro no console.
A entrada de movimentos geralmente segue o formato `origem destino` (ex: `e2 e4`).
