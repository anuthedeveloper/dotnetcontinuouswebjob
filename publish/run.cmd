@echo off
:loop
echo Starting the executable...
ContinuousWebJob.exe
echo Executable finished. Restarting...
goto loop
