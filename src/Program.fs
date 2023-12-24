open MatrixTypes

open MatrixTypes

[<EntryPoint>]
let main argv =
    // 2x2
    let matrix2x2 = Matrix2x2(1.0, 2.0, 3.0, 4.0)
    printfn "Determinant of 2x2 Matrix: %f" (matrix2x2.Determinant())

    // 3x3
    let matrix3x3 = Matrix3x3(1.0, 0.0, 2.0, 0.0, 1.0, 0.0, 2.0, 0.0, 1.0)
    printfn "Determinant of 3x3 Matrix: %f" (matrix3x3.Determinant())

    // 4x4
    let mV = Array2D.init 4 4 (fun i j -> float (i * 4 + j))
    let matrix4x4 = Matrix4x4(mV)
    printfn "Determinant of 4x4 Matrix: %f" (matrix4x4.Determinant())

    0

