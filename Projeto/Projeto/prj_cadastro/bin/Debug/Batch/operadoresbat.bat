@echo off
title SI - Jogo de calculos
color 0a

:var
set /a i=0
set /a pont=0
set nome=Player 1
goto Menu

:Menu
cls
echo.
echo ------------------------------------------------------------------
echo                    Operadores Matemáticos
echo ------------------------------------------------------------------
echo [J] jogar
echo [L] Pontuacao dos Jogadores
echo [E] Encerrar Jogo
echo ------------------------------------------------------------------
set /p op=Digite sua opcao:

if /i %op% == j (goto:Sorteio) 

if /i %op% == l (goto:score)

if /i %op% == e (exit)

:Sorteio
set /a N1=(%Random% %% 10) + 1
set /a N2=(%Random% %% 10) + 1
set /a sort=(%Random% %% 3) + 1
set /a operador=0
if %sort% == 1 ( set operador=+)
if %sort% == 2 ( set operador=-)
if %sort% == 3 ( set operador=*)
goto conta

:conta
if %sort% == 1 ( 
    set /a resultado= %N1% + %N2%)
if %sort% == 2 ( 
    set /a resultado= %N1% - %N2%)
if %sort% == 3 ( 
    set /a resultado= %N1% * %N2%)

goto jogo

:jogo 
echo.
cls
echo ------------------------------------------------------------------
echo                 %N1% %operador% %N2% = ???
echo ------------------------------------------------------------------
echo       Quantidade de Acertos: %i%  
echo ------------------------------------------------------------------
echo.
set /p ans=Digite o resultado da conta:

if %ans% == %resultado% (goto:acertos)

if %ans% NEQ %resultado% (goto:errado)

:errado
echo.
echo -------------------------------------------
echo Errou! O Resultado era: %resultado%
echo -------------------------------------------
set /a i=0
set /p resp=Deseja jogar novamente? [S/N]:
if /i %resp% == S (goto:Sorteio) else (goto:Menu)


:acertos
echo.
echo ---------------------------
echo Parabens voce acertou!
echo Resultado Correto: %resultado%
echo ---------------------------
echo.
pause
set /a i=%i%+1
set /a pont=%pont%+1
goto Sorteio


:score
cls
title Pontuacao dos jogadores
echo.
echo ---------------------------------------------------------------
echo                PONTUACAO DO JOGADOR
echo ---------------------------------------------------------------
echo DATA         HORA        NOME JOGADOR    PONTUACAO JOGADOR
echo ---------------------------------------------------------------
echo %date%  %time%  %nome%           %pont% 
echo ---------------------------------------------------------------
echo.
pause
goto Menu








