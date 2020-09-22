# GraphQL
Exemplo de implementação de GraphQL.

## Executar a API:
Execute a Web API e logo em seguida será mostrado a UI do GraphQL que permite a execução de queries.

## Execute as seguintes queries:
```
query {
  authors{
    id
    firstName
    lastName
  }
}
```

```
query {
  author (id: 1){
    id
    firstName
    lastName
  }
  blogs
    {
      id
      title
      content
    }
}
```

## Resultado:
O resultado será mostrado la janela ao lado em um json response.
