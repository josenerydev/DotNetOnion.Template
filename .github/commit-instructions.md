**Tarefa:** Gerar mensagens de commit seguindo a especificação do **Conventional Commits 1.0.0** em português (pt-br).

---

### Passos para Realizar a Tarefa

1. **Identifique o Tipo de Alteração:**
   - Determine se é um `feat`, `fix` ou outro tipo conforme especificado.
2. **Defina o Escopo (Opcional):**
   - Se a alteração afetar uma parte específica do código, inclua o escopo.
3. **Escreva a Descrição:**
   - Resuma a alteração em uma frase no imperativo.
4. **Adicione o Corpo (Opcional):**
   - Forneça detalhes adicionais se necessário.
5. **Inclua Rodapé(s) (Opcional):**
   - Indique `BREAKING CHANGE:` se houver alterações incompatíveis.
   - Referencie issues ou tickets relevantes.
6. **Revise a Mensagem:**
   - Verifique se a mensagem segue o formato e está em português claro.

---

### Exemplo(s)

- **Formato da Mensagem de Commit:**

  ```
  <tipo>[escopo opcional][!]: <descrição>

  [corpo opcional]

  [rodapé(s) opcional(is)]
  ```

- **Exemplos de Mensagens de Commit:**

  - **Novo Recurso:**
    ```
    feat: adiciona funcionalidade de exportação de dados
    ```
  - **Correção de Bug:**
    ```
    fix: corrige falha ao salvar configurações do usuário
    ```
  - **Commit com Escopo:**
    ```
    feat(ui): melhora responsividade do menu lateral
    ```
  - **Commit com BREAKING CHANGE usando `!`:**
    ```
    refactor!: atualiza biblioteca de autenticação
    ```
  - **Commit com BREAKING CHANGE no Rodapé:**
    ```
    refactor: reorganiza estrutura de diretórios do projeto

    BREAKING CHANGE: caminhos de importação foram alterados; atualize as referências nos arquivos dependentes.
    ```
  - **Commit de Documentação:**
    ```
    docs: atualiza README com instruções de instalação
    ```
  - **Commit Referenciando Issue:**
    ```
    fix: resolve erro de carregamento na página inicial

    Closes #42
    ```

---

### Notas para a Resposta

- A resposta deve ser **apenas** a mensagem de commit final, seguindo todas as instruções acima, sem explicações ou comentários adicionais.
- Utilize espaços reservados para dados variáveis onde necessário.

---

**Objetivo:**

Sempre que solicitado, gere mensagens de commit que:

- **Estão em conformidade com o formato do Conventional Commits 1.0.0.**
- **Estão escritas em português (pt-br).**
- **Descrevem claramente as alterações realizadas no código.**
- **Incluem todas as informações relevantes (tipo, escopo, descrição, corpo, rodapé).**

---