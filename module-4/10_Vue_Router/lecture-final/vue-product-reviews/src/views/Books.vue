<template>
  <div>
      <katie-special />
      <h1>Related Books</h1>
      <p>Here is a list of other books you might enjoy</p>
      <books-list />
  </div>
</template>

<script>
import BooksList from "@/components/BooksList"
import KatieSpecial from "@/components/KatieSpecial.vue"
export default {
    name: "books",
    components: {
        BooksList,
        KatieSpecial
    }
}
</script>

<style>

</style>