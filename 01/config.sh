#!/bin/bash
echo "Seu nome de usuário é:"
whoami
echo "Hora atual e tempo que o computador está ligado:"
uptime
echo "Diretório atual:"
pwd  
echo "Configuração das interfaces de rede:"
ifconfig
echo "Alterando a configuração da interface de rede eno1:"
ifconfig eno1 192.168.0.5 netmask 255.255.255.0
echo "Configuração das interfaces de rede:"
ifconfig
echo "Qual é o seu nome?"
read nome;
echo "Seu nome é $nome!"
