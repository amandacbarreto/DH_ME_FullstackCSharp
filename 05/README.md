# Aula 05 (07/06/2022) - Resolvendo conflitos no controle de versão

## Listando os commits (alterações no histórico)

Para desfazer commit, use os comandos:

```bash
git log
git log -5  #número de commits que você quer visualizar
```

## Desfazendo alterações não rastreadas

Para desfazer alterações não rastreadas, ou seja, alterações que foram inseridas no stage area através do comando `git add .`, use os comandos:

```
git reset
```

## Desfazendo alterações do histórico

> **Note**
> Desfazer = pegar e jogar fora
> Reverter = não apaga do histórico

```bash
git reset
git reset numeroComitHash # exclui os commits à frente do indicado, mas deixa os códigos alterados para novo commit
git reset HEAD~5 # ou o número de commits a partir do HEAD que você quer tirar do histórico
```

## Revertendo alterações do histórico

```
git revert
git rebase
```

## Reescrevendo o histórico

```
git revert
git rebase
```

## Outros comandos

```bash
git reflog #mostra todas as alterações de log
git checkout numeroHashCommit
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/blob/main/05/README.md)
- [Atividade entregue](https://github.com/amandacbarreto/7-6-22aula05_resolvendo-conflitos.git)
