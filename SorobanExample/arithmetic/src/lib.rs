#![no_std]
use soroban_sdk::{contract, contracterror, contractimpl, log, Env};

#[contract]
pub struct ArithmeticContract;

#[contracterror]
#[derive(Copy, Clone, Eq, PartialEq, Debug)]
pub enum ContractError {
    DivideByZero = 1,
}

#[contractimpl]
impl ArithmeticContract {
    pub fn divide_two_numbers(env: Env, number1: i64, number2: i64) -> Result<i64, ContractError> {
        if number2 == 0 {
            log!(&env, "Divide by zero failure.");
            return Err(ContractError::DivideByZero);
        }

        Ok(number1 / number2)
    }
}
