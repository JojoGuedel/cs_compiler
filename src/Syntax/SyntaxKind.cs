namespace Solver_01
{
    enum SyntaxKind
    {
        InvalidCharToken,
        WhitespaceToken,
        NumberToken,
        NameToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        OpenBracketToken,
        CloseBracketToken,
        OpenCurlyBracketToken,
        CloseCurlyBracketToken,
        OpenAngleBracketToken,
        CloseAngleBracketToken,
        EndOfFileToken,

        NumberExpression,
        BinaryExpression,
    }
}