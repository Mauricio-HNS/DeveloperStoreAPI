# Ambev Developer Evaluation

## Visão Geral
Este é um sistema desenvolvido para a avaliação de desenvolvedores na Ambev, contendo funcionalidades relacionadas à gestão de vendas e itens, incluindo criação, modificação, cancelamento e consulta de vendas.

## Tecnologias Utilizadas
- **Backend:** ASP.NET Core  
- **Frontend:** Flutter (caso aplicável)  
- **Banco de Dados:** SQL Server  
- **Arquitetura:** Microservices (se aplicável)  
- **Mensageria:** RabbitMQ / SignalR (se aplicável)  
- **Containerização:** Docker

## Estrutura do Projeto
```
/Ambev.DeveloperEvaluation
|-- /Application
|   |-- /Ports
|   |   |-- ISaleService.cs
|   |-- /Sales
|   |   |-- SaleDto.cs
|
|-- /Domain
|   |-- /Entities
|   |   |-- Sale.cs
|   |-- /Events
|   |   |-- SaleCreatedEvent.cs
|   |   |-- SaleModifiedEvent.cs
|   |   |-- SaleCancelledEvent.cs
|   |   |-- ItemCancelledEvent.cs
|
|-- /Infrastructure
|   |-- (Implementação de repositórios, contexto de banco, etc.)
|
|-- /API
|   |-- Controllers
|   |   |-- SaleController.cs
|
|-- /Tests
|   |-- (Testes unitários e de integração)
```

## Configuração do Ambiente
### Requisitos
- .NET 9.0+
- Docker Desktop
- SQL Server
- Visual Studio 2022+

### Passos
1. Clone o repositório:  
   ```sh
   git clone https://github.com/empresa/ambev-developer-evaluation.git
   cd ambev-developer-evaluation
   ```
2. Configure a string de conexão no **appsettings.json**
3. Rode as migrações para criar o banco de dados:
   ```sh
   dotnet ef database update
   ```
4. Execute a aplicação:
   ```sh
   dotnet run --project API
   ```

## Endpoints da API
### Criar uma Venda
```http
POST /api/sales
```
**Body:**
```json
{
  "customerName": "João Silva",
  "totalAmount": 100.50,
  "status": "Pending",
  "items": [
    { "productId": 1, "quantity": 2, "price": 50.25 }
  ]
}
```

### Obter todas as Vendas
```http
GET /api/sales
```

### Obter uma Venda por ID
```http
GET /api/sales/{id}
```

## Contribuição
Para contribuir:
1. Crie um fork do repositório
2. Crie uma branch para sua feature (`git checkout -b minha-feature`)
3. Faça o commit das suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Envie para o repositório (`git push origin minha-feature`)
5. Abra um Pull Request

## Contato
Para mais informações, entre em contato com a equipe de desenvolvimento.

