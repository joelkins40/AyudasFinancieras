# Script para corregir la codificación de archivos
# Convierte archivos de codificación incorrecta a UTF-8

param(
    [Parameter(Mandatory=$true)]
    [string]$ProjectPath
)

Write-Host "Iniciando corrección de codificación de archivos..."

# Buscar todos los archivos .cshtml, .cs, .js, .css
$files = Get-ChildItem -Path $ProjectPath -Include "*.cshtml", "*.cs", "*.js", "*.css" -Recurse

foreach ($file in $files) {
    try {
        # Leer el contenido del archivo detectando la codificación
        $content = Get-Content -Path $file.FullName -Raw -Encoding Default
        
        # Solo procesar si el archivo contiene caracteres problemáticos
        if ($content -match '�') {
            Write-Host "Procesando: $($file.Name)"
            
            # Hacer copias de seguridad
            $backupPath = $file.FullName + ".backup"
            Copy-Item -Path $file.FullName -Destination $backupPath -Force
            
            # Corregir caracteres comunes mal codificados
            $content = $content -replace 'aplicaci�n', 'aplicación'
            $content = $content -replace 'm�viles', 'móviles'
            $content = $content -replace '�rea', 'área'
            $content = $content -replace 't�ctil', 'táctil'
            $content = $content -replace 'Funci�n', 'Función'
            $content = $content -replace 'opci�n', 'opción'
            $content = $content -replace 'validaci�n', 'validación'
            $content = $content -replace 'Configuraci�n', 'Configuración'
            $content = $content -replace 'est�', 'está'
            $content = $content -replace 'despu�s', 'después'
            $content = $content -replace '�til', 'útil'
            $content = $content -replace 'Selecci�n', 'Selección'
            $content = $content -replace 'Informaci�n', 'Información'
            $content = $content -replace 'Acad�mica', 'Académica'
            $content = $content -replace 'Oto�o', 'Otoño'
            $content = $content -replace 'Matr�cula', 'Matrícula'
            $content = $content -replace 'electr�nica', 'electrónica'
            $content = $content -replace 'impresi�n', 'impresión'
            $content = $content -replace 'm�s', 'más'
            
            # Escribir el archivo con codificación UTF-8
            $content | Out-File -FilePath $file.FullName -Encoding UTF8 -NoNewline
            
            Write-Host "  ✓ Corregido: $($file.Name)"
        }
    }
    catch {
        Write-Host "  ✗ Error procesando $($file.Name): $($_.Exception.Message)" -ForegroundColor Red
    }
}

Write-Host "Proceso completado."