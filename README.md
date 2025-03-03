# DotNetOnion.Template

Template para criação rápida de projetos seguindo a Onion Architecture com boas práticas.

## 📁 Estrutura

```
Solution 'DotNetOnion.Template'
   ├── .template.config/
   ├── Solution Items/
   ├── src/  (Código-fonte)
   └── tests/ (Testes)
```

## 🚀 Instalação

```sh
dotnet new install .
```

## 📝 Verificar Template

```sh
dotnet new list
```

## 💻 Criar Novo Projeto

```sh
dotnet new onion -n MeuProjeto
```

## 🔄 Atualização

```sh
dotnet new uninstall . && dotnet new install .
```

## 🗑️ Remover Template

```sh
dotnet new uninstall DotNetOnion.Template
```
