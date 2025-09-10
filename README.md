
# AgendaDeContatos

Projeto desktop em **.NET Windows Forms** destinado à **gerência de contatos** (CRUD), **banco de dados SQLite**. Permite cadastrar, editar, excluir e listar contatos contendo Nome, Email e Telefone.

---

## Funcionalidades

* **CRUD completo de contatos**
* **Persistência de dados**: suporte a arquivo `.txt` ou banco **SQLite**
* **Interface gráfica intuitiva** utilizando **Windows Forms**
* **Validação básica de dados** (nome, email e telefone)

---

## Arquitetura do Projeto

O projeto segue uma **estrutura MVC simplificada**:

### 1. Views (Forms)

* **MainForm**

  * Componente: `DataGridView` para exibição de contatos
  * Botões: Adicionar, Editar, Excluir, Sair

* **ContatoForm**

  * Componentes: `TextBox` para Nome, Email e Telefone
  * Botões: Salvar, Cancelar

### 2. Controller

* **Contato.cs**

  ```csharp
  public int Id { get; set; }         // Necessário se usar banco
  public string Nome { get; set; }
  public string Email { get; set; }
  public string Telefone { get; set; }
  ```

* Responsável pelo **controle de fluxo** entre Views e Models, validando dados e gerenciando operações CRUD.

### 3. Models

* **Banco.cs**

  * Gerencia conexões, consultas e gravações

---

## Estrutura de Pastas

```
/AgendaContatos
│
├─ /Forms        → Telas WinForms
│  └─ MainForm.cs
│
├─ /Controller   → Lógica de controle
│  └─ Contato.cs
│
├─ /Models       → Comunicação com persistência
│  └─ Banco.cs
```
