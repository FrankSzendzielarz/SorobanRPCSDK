grammar StellarXdr;

// Parser Rules
compilationUnit
    : (includeStatement | namespaceDefinition)*
    ;

includeStatement
    : '%#include' STRING_LITERAL
    ;

namespaceDefinition
    : 'namespace' identifier '{' definition* '}'
    ;

definition
    : typeDefinition
    | constantDefinition
    | includeStatement
    ;

typeDefinition
    : typedefDefinition
    | enumDefinition
    | structDefinition
    | unionDefinition
    ;

typedefDefinition
    : 'typedef' declaration ';'
    ;

enumDefinition
    : 'enum' identifier enumBody ';'
    ;

enumBody
    : '{' enumMember (',' enumMember)* ','? '}'
    ;

enumMember
    : identifier ('=' (constant | identifier))?
    ;

structDefinition
    : 'struct' identifier structBody ';'
    ;

structBody
    : '{' structMember* '}'
    ;

structMember
    : declaration ';'
    ;

unionDefinition
    : 'union' identifier unionBody ';'
    ;

unionBody
    : 'switch' '(' declaration ')' '{' caseSpec+ (defaultCase)? '}'
    ;

caseSpec
    : ('case' value ':')+ declaration ';'
    ;

defaultCase
    : 'default' ':' declaration ';'
    ;

declaration
    : typeSpecifier identifier arraySizeSpec?
    | 'opaque' identifier arraySizeSpec
    | 'string' identifier arraySizeSpec
    | typeSpecifier '*' identifier
    | 'void'
    ;

typeSpecifier
    : baseType
    | identifier
    ;

baseType
    : 'unsigned'? ('int' | 'hyper')
    | 'float'
    | 'double'
    | 'quadruple'
    | 'bool'
    | enumTypeSpec
    | structTypeSpec
    | unionTypeSpec
    ;

enumTypeSpec
    : 'enum' enumBody
    ;

structTypeSpec
    : 'struct' structBody
    ;

unionTypeSpec
    : 'union' unionBody
    ;

arraySizeSpec
    : '[' value ']'      // Fixed size array
    | '<' value? '>'     // Variable size array with optional max
    ;

constantDefinition
    : 'const' identifier '=' constant ';'
    ;

value
    : constant
    | identifier
    ;

constant
    : INTEGER_CONSTANT
    | HEXADECIMAL_CONSTANT
    | OCTAL_CONSTANT
    ;

identifier
    : IDENTIFIER ('::' IDENTIFIER)*
    ;

// Lexer Rules
IDENTIFIER
    : [a-zA-Z][a-zA-Z0-9_]*
    ;

INTEGER_CONSTANT
    : '0'
    | '-'? [1-9][0-9]*
    ;

HEXADECIMAL_CONSTANT
    : '0x' [a-fA-F0-9]+
    ;

OCTAL_CONSTANT
    : '0' [0-7]+
    ;

STRING_LITERAL
    : '"' (~["\r\n])* '"'
    ;

WHITESPACE
    : [ \t\r\n]+ -> skip
    ;

BLOCK_COMMENT
    : '/*' .*? '*/' -> skip
    ;

LINE_COMMENT
    : '//' ~[\r\n]* -> skip
    ;

PREPROCESSOR_LINE
    : '%' ~[\r\n]* -> skip
    ;