#![no_std]
use soroban_sdk::{
    contract, contracterror, contractimpl, log, symbol_short, token, Address, Env, Symbol,
};

#[contract]
pub struct SorobanAuthContract;

#[contracterror]
#[derive(Copy, Clone, Eq, PartialEq, Debug)]
pub enum ContractError {
    InitValuesAlreadySet = 1,
    RecipientIsBuyer = 2,
    InvalidAmount = 3,
    NotInitialised = 4,
}

const XLMADDRESS: Symbol = symbol_short!("XLMADDR");

#[contractimpl]
impl SorobanAuthContract {
    pub fn pay(
        env: Env,
        payer: Address,
        recipient: Address,
        amount: i128,
    ) -> Result<(), ContractError> {
        log!(&env, "Starting pay.");

        log!(&env, "Authorising payer.");
        payer.require_auth();
        log!(&env, "Payer authorised.");

        log!(&env, "Getting XLM native token address.");
        if !env.storage().instance().has(&XLMADDRESS) {
            log!(
                &env,
                "XLM native token address not found. Contract not initialised."
            );
            return Err(ContractError::NotInitialised);
        }
        let xlm_address: Address = env.storage().instance().get(&XLMADDRESS).unwrap();
        log!(&env, "XLM native token address obtained.");

        if payer == recipient {
            log!(&env, "Cannot pay to payer.");
            return Err(ContractError::RecipientIsBuyer);
        }

        if amount <= 0 {
            log!(&env, "Amount must be positive.");
            return Err(ContractError::InvalidAmount);
        }

        log!(&env, "Transferring.");
        let token = token::Client::new(&env, &xlm_address);
        token.transfer(&payer, &recipient, &amount);
        log!(&env, "Transferred successfully.");

        log!(&env, "Ending pay.");
        Ok(())
    }

    pub fn init(env: Env, native_asset: Address) -> Result<(), ContractError> {
        if env.storage().instance().has(&XLMADDRESS) {
            return Err(ContractError::InitValuesAlreadySet);
        }
        env.storage().instance().set(&XLMADDRESS, &native_asset);
        Ok(())
    }
}
