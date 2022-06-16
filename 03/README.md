# Aula 03 (03/06/2022) - Ramificando o controle de versão

## O que é ramificação?

Uma ramificação permite isolar o código-fonte de uma nova alteração, evitando um represamento do código-fonte.

## Git branch

Com as branches (ou ramificações), vários desenvolvedores podem trabalhar paralelamente no mesmo projeto.

O branch pode ser usado para três finalidades diferentes:

- criar ramificações
- listar ramificações
- excluir ramificações.

**Para criar uma nova branch local**:

```
git branch <nome-da-branch>
```

**Para upar a nova branch para o repositório remoto**:

```
git push -u <remote> <nome-da-branch>
```

**Para ver/listar as ramificações**:

```
git branch //opção 1
git branch --list  //opção 2
```

O **`*`** que aparece ao lado da branch indica qual a branch que está em uso.

**Para deletar uma ramificação**:

```
git branch -d <nome-da-branch>
```

## Git checkout

Para trabalhar em uma branch, primeiro é preciso mudar para ela. Assim, o principal objetivo do git checkout é ajudar você a mudar de branch ou então a verificar arquivos e commits.

**Para mudar de branch**:

```
git checkout <nome-da-ramificação>
```

**Para criar e ir para um branch num mesmo comando**:

```
git checkout -b <nome-da-branch>
```

## Git merge

**Para unificar duas branches**:

```
git merge <nome-da-ramificação-que-se-juntará-a-atual>
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/tree/main/03)
- [Atividade entregue](https://github.com/renatakim/aula03_ramificando-o-controle-de-versao)
