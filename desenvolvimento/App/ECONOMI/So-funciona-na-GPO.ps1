# Obter o nome da máquina
$computerName = $env:COMPUTERNAME

# Obter o caminho do diretório de saída
$outputDirectory = "C:\Caminho\Para\Seu\Diretorio"  # Substitua pelo caminho desejado

# Criar o nome do arquivo com base no nome da máquina e na data/hora
$fileName = "$computerName" + "_BatteryReport_$(Get-Date -Format 'yyyyMMdd_HHmmss').html"

# Caminho completo para o arquivo de saída
$outputPath = Join-Path -Path $outputDirectory -ChildPath $fileName

# Executar o comando powercfg para gerar o relatório da bateria
powercfg /batteryreport /output $outputPath

# Exibir mensagem indicando o sucesso
Write-Host "Relatório da bateria gerado com sucesso em: $outputPath"
