open MathNet.Numerics.LinearAlgebra

let matrix = Matrix<double>.Build.Dense(2, 2, [| 1.0; 2.0; 3.0; 4.0 |])

printfn "%A" matrix

let transposed = matrix.Transpose()

printfn "%A" transposed

