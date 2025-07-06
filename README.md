# EventEase
Projeto Blazor EventEase

🤖 Assistência do Copilot no Desenvolvimento
Durante o desenvolvimento do EventEase, utilizei o Copilot como suporte técnico e de boas práticas em várias etapas do projeto. Abaixo está um resumo das contribuições:

🧱 Estruturação do Projeto
Auxiliou na definição da arquitetura básica do projeto, organizando pastas como Pages, Components, Models e Services.

Orientou sobre convenções de nomenclatura para rotas e componentes em Blazor.

📄 Criação de Models e Validações
Gerou o modelo EventModel com propriedades como Title, Date, Location e Description, aplicando validações com DataAnnotations.

🛠️ Implementação de Services
Criou um serviço EventService com operações de CRUD em memória.

Explicou o uso do padrão Singleton para manter dados disponíveis entre páginas.

📋 Formulários com Validação
Desenvolveu o formulário EventForm.razor com uso de EditForm, InputText, InputDate e mensagens de erro utilizando Bootstrap.

Aplicou DataAnnotationsValidator e ValidationSummary para feedback ao usuário.

🧩 Criação de Componentes Reutilizáveis
Criou o componente EventCard.razor com uso de @Parameter e EventCallback para exibir dados e lidar com exclusão de eventos.

Adicionou responsividade e estilo usando Bootstrap 5.

🎨 Estilização com Bootstrap
Melhorou a interface de todas as páginas aplicando classes Bootstrap como card, form-control, btn, row, alert, entre outras.

Sugeriu práticas para tornar os componentes responsivos e visualmente padronizados.

💡 Boas práticas
Forneceu explicações detalhadas sobre o funcionamento do Blazor, data binding, callbacks e estrutura de componentes.

Indicou caminhos para futuras melhorias, como persistência com banco de dados, modais e validação avançada.
