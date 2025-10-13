# Neocare

Neocare é uma aplicação web desenvolvida em ASP.NET Core Razor Pages para auxiliar no monitoramento e gerenciamento de níveis de estresse.

## Objetivo do Projeto

O projeto visa fornecer uma ferramenta digital para que usuários possam registrar, monitorar e acompanhar seus níveis de estresse ao longo do tempo, auxiliando na identificação de padrões e no gerenciamento da saúde mental.

## Escopo

### Funcionalidades Principais

1. **Registro de Níveis de Estresse**
   - Cadastro do nível de estresse (escala 1-10)
   - Descrição da situação
   - Registro de sintomas associados
   - Data e hora do registro

2. **Visualização de Registros**
   - Listagem de todos os registros de estresse
   - Filtragem por período
   - Visualização detalhada de cada registro

3. **Gestão de Registros**
   - Criação de novos registros
   - Atualização de registros existentes
   - Remoção de registros

## Requisitos

### Requisitos Funcionais

1. **Gerenciamento de Registros de Estresse**
   - O sistema deve permitir criar novos registros de estresse
   - O sistema deve permitir visualizar registros existentes
   - O sistema deve permitir atualizar registros existentes
   - O sistema deve permitir excluir registros

2. **Entrada de Dados**
   - O sistema deve aceitar níveis de estresse de 1 a 10
   - O sistema deve permitir a entrada de descrições textuais
   - O sistema deve permitir o registro de múltiplos sintomas

3. **Visualização de Dados**
   - O sistema deve exibir registros em ordem cronológica
   - O sistema deve permitir a visualização detalhada de cada registro

### Requisitos Não Funcionais

1. **Usabilidade**
   - Interface intuitiva e responsiva
   - Tempo de resposta inferior a 2 segundos
   - Suporte a diferentes dispositivos e navegadores

2. **Segurança**
   - Autenticação de usuários
   - Proteção dos dados pessoais
   - Registros associados apenas ao usuário que os criou

3. **Tecnologias**
   - ASP.NET Core 8.0
   - Razor Pages
   - C# 12.0
   - Armazenamento em memória
   - Bootstrap para interface

## Arquitetura

O projeto segue uma arquitetura em camadas:

1. **Camada de Domínio**
   - Entidades
   - Interfaces de repositório
   - Regras de negócio

2. **Camada de Aplicação**
   - Serviços
   - DTOs
   - Manipulação de erros

3. **Camada de Infraestrutura**
   - Implementação do repositório
   - Persistência de dados em memória

4. **Camada de Apresentação**
   - Razor Pages
   - Componentes de interface
   - Validações de formulário