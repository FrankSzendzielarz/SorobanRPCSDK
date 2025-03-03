#![no_std]
use soroban_sdk::{contract, contracterror, contractimpl, contracttype, log, Address, Env, String};

#[contracterror]
#[derive(Copy, Clone, Debug, Eq, PartialEq)]
pub enum Error {
    // Add any error codes you need
    InvalidInput = 1,
}

#[contracttype]
#[derive(Clone)]
pub struct FlatTestReq {
    pub number: u32,
    pub word: String,
}

#[contracttype]
#[derive(Clone)]
pub struct NestedTestReq {
    pub numba: u32,
    pub flat: FlatTestReq,
    pub word: String,
}

#[contract]
pub struct NestedStructContract;

#[contractimpl]
impl NestedStructContract {
    pub fn flat_param_test(env: Env, req: FlatTestReq) -> Result<u32, Error> {
        // Return the number value from the FlatTestReq input
        log!(
            &env,
            "Processing flat_param_test with number: {}",
            req.number
        );
        Ok(req.number)
    }

    pub fn nested_param_test(env: Env, req: NestedTestReq) -> Result<u32, Error> {
        // Return the sum of both number values from the NestedTestReq input
        let sum = req.numba + req.flat.number;
        log!(&env, "Processing nested_param_test with sum: {}", sum);
        Ok(sum)
    }
}
