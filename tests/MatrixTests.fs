namespace MatrixTests

open Microsoft.VisualStudio.TestTools.UnitTesting
open MatrixTypes

[TestClass]
type MatrixTests() =

    [TestMethod]
    member this.``2x2 matrix determinant should be correct`` () =
        let matrix = Matrix2x2(1.0, 2.0, 3.0, 4.0)
        Assert.AreEqual(-2.0, matrix.Determinant())

    [TestMethod]
    member this.``3x3 matrix determinant should be correct`` () =
        let matrix = Matrix3x3(1.0, 0.0, 2.0, 0.0, 1.0, 0.0, 2.0, 0.0, 1.0)
        Assert.AreEqual(-2.0, matrix.Determinant())


