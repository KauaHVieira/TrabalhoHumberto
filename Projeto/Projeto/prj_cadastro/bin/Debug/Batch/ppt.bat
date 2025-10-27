@echo off
Title PedraPapelTesoura Humberto
color 0a

:Inicio
set /a wins=0
set /a losses=0
set /a ties=0
set nome=Player 1
goto Menu

:Menu
cls
echo ==========================================
echo      -=-Pedra-=-Papel-=-Tesoura-=-
echo                PREMIUM
echo ==========================================
echo.
echo [1] PEDRA
echo [2] PAPEL
echo [3] TESOURA
echo [4] LAGARTO
echo [5] SPOCK
echo [E] ENCERRAR JOGO
echo [R] REGRAS
echo ==========================================
set /p op=Escolha uma opcao:

if %op% == 1 ( set escolha="PEDRA"
goto Sorteio)

if %op% == 2 ( set escolha="PAPEL"
goto Sorteio)

if %op% == 3 ( set escolha="TESOURA"
goto Sorteio)

if %op% == 4 ( set escolha="LAGARTO"
goto Sorteio)

if %op% == 5 ( set escolha="SPOCK"
goto Sorteio)

if /i %op% == E (exit)

if /i %op% == R (goto:Regras)

:Sorteio
set /a sort=(%Random% %% 5) + 1
if %sort% == 1 ( set maquina="PEDRA")

if %sort% == 2 ( set maquina="PAPEL")

if %sort% == 3 ( set maquina="TESOURA")

if %sort% == 4 ( set maquina="LAGARTO")

if %sort% == 5 ( set maquina="SPOCK")

goto Jogo

:Jogo
echo %op%
echo %escolha%
echo %maquina%
echo %sort%
pause

if %op% == %sort% (
    set result="EMPATOU"
    set /a ties=%ties%+1
    goto Resultado
)

if %op% == 1 (
    if %sort% == 2 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 3 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 4 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 5 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
)

if %op% == 2 (
    if %sort% == 1 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 3 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 4 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 5 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
)

if %op% == 3 (
    if %sort% == 2 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 1 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 4 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 5 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
)

if %op% == 4 (
    if %sort% == 1 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 2 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 3 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 5 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
)

if %op% == 5 (
    if  %sort% == 1 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 2 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
    if %sort% == 3 (
        set result="GANHOU"
        set /a wins=%wins%+1
        goto Resultado
    )
    if %sort% == 4 (
        set result="PERDEU"
        set /a losses=%losses%+1
        goto Resultado
    )
)


:Resultado
echo Player 1 escolheu: %escolha%
echo Computador escolheu: %maquina%
echo.
echo VOCE....%result%!!
echo.
echo == PLACAR DO JOGO ==
echo VITORIAS: %wins%
echo DERROTAS: %losses%
echo EMPATES: %ties%
echo ====================
set /p resp=Deseja jogar novamente? [S/N]:
if /i %resp% == s (goto:Menu) else (exit)



:Regras
cls
echo ==========================================
echo Regras do Jogo Pedra, Papel, Tesoura, Lagarto, Spock
echo ==========================================
echo.
echo - Pedra quebra Tesoura e esmaga Lagarto
echo - Tesoura corta Papel e decapita Lagarto
echo - Papel cobre Pedra e refuta Spock
echo - Lagarto come Papel e envenena Spock
echo - Spock quebra Tesoura e vaporiza Pedra
echo.
pause
goto Menu