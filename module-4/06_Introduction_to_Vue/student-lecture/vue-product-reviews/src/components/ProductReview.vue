<template>
    <div class="main">
    <h2> Product Reviews for{{name}}</h2>
    <p class = "description">{{description}}</p>

    </div>
</template>
<script>
export default {
    name:'product-review',
    data() {
        return{
        name:'Cigar Paty for Dummies',
        description: 'Make your cigar parties the best'
        }
    }
}
</script>
<style scoped>
                       
</style>