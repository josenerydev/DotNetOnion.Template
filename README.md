# DotNetOnion.Template

Template para criação rápida de projetos seguindo a Onion Architecture com estrutura moderna e boas práticas.

## 📋 Estrutura do Template

Este template cria uma solução com a seguinte estrutura:

```
Solution 'DotNetOnion.Template'
   ├── .template.config
   │   └── template.json
   ├── Solution Items
   │   ├── .editorconfig
   │   ├── .templateignore
   │   ├── Directory.Build.props
   │   └── Directory.Packages.props
   ├── src/
   │   └── (Projetos do código-fonte)
   └── tests/
       └── (Projetos de testes)
```

## 🚀 Instalação

Para instalar o template:

```powershell
dotnet new install C:\caminho\para\DotNetOnion.Template
```

## 📝 Listagem

Para verificar se o template foi instalado corretamente:

```powershell
dotnet new list
```

Você deverá ver `dotnet-onion` na lista de templates disponíveis.

## 💻 Uso

Para criar um novo projeto usando o template:

```powershell
dotnet new dotnet-onion -n MeuProjeto
```

### Opções disponíveis:

- `-n|--name`: Nome do projeto (obrigatório)
- `--Framework`: Framework do .NET (padrão: net8.0)
  - Valores possíveis: net6.0, net7.0, net8.0

Exemplo com opção de framework:

```powershell
dotnet new dotnet-onion -n MeuProjeto --Framework net7.0
```

## 🔄 Atualização

Se você fizer alterações no template e quiser atualizá-lo:

1. Desinstale a versão atual:

```powershell
dotnet new uninstall C:\caminho\para\DotNetOnion.Template
```

2. Reinstale o template:

```powershell
dotnet new install C:\caminho\para\DotNetOnion.Template
```

## 🗑️ Desinstalação

Para remover o template do seu sistema:

```powershell
dotnet new uninstall DotNetOnion.Template
```

## 📖 Desenvolvimento

Se você deseja modificar este template:

1. Clone o repositório
2. Faça suas alterações
3. Atualize o arquivo .template.config/template.json conforme necessário
4. Reinstale o template usando as instruções acima

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

## 📄 Licença

Este projeto está licenciado sob a licença MIT.


# Use o template para criar um novo projeto
dotnet new dotnet-onion -n MeuNovoProjeto
```

Se você precisar fazer alterações no template e atualizá-lo, primeiro desinstale a versão atual:

```powershell
dotnet new uninstall .
```

E então reinstale-o após as alterações:

```powershell
dotnet new install .
```