Imports MelonLoader

<Assembly: MelonInfo(GetType(MyMod), "MyVBMod", "1.0.0", "unreliablecode", "Description of your mod.")>
<Assembly: MelonGame("GameName", "DeveloperName")>

Namespace MyVBMod
    Public Class MyMod
        Inherits MelonMod

        Public Overrides Sub OnApplicationStart()
            UnityEngine.Debug.Log("My VB Mod: ApplicationStart")
        End Sub

        Public Overrides Sub OnUpdate()
            UnityEngine.Debug.Log("My VB Mod: Update")
        End Sub
    End Class
End Namespace
