##   
🔹 _Fase 1 – Básico (CRUD Simples, Console ou WinForms)_

Objetivo: dominar _POO_, coleções, persistência simples (arquivos ou SQLite).

- _Agenda de Contatos_
    
    - CRUD de contatos (nome, email, telefone).
    - Salvar em arquivo .txt ou banco SQLite.


---

# Componentes Necessários

###  **1. Views**
 
- **MainForm** →
    
    - `DataGridView` para listar contatos.
        
    - Botões: **Adicionar, Editar, Excluir, Sair**.
        
- **ContatoForm** →
    
    - `TextBox` para Nome, Email, Telefone.
        
    - Botões: **Salvar, Cancelar**.

###  **2. Controller**

    public int Id { get; set; }         // se usar banco
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
### **3. Models**

	-Banco.cs 

---

## Estrutura do Projeto


/AgendaContatos
│
├─ /Forms    → Telas WinForms
│   └─ MainForm.cs
│
├─ /Controller → 
│   └── Contato.cs       → Nome, Email, Telefone
│
├─ /Models  → Comunicação com o banco de dados
│   └─ Banco.cs 







